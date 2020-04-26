﻿module CountriesChartViz.Analysis

open System
open Statistics

type CountryIsoCode = string

type CountryData = {
    CountryIsoCode: CountryIsoCode
    CountryName: string
    Data: SeriesValues<DateTime>
}

type CountriesData = Map<CountryIsoCode, CountryData>

type CountriesSelection =
    | Scandinavia

let parseCountriesCsv daysOfMovingAverage: CountriesData =

    let countriesData =
        Data.CountriesData.countriesRawData
        |> Seq.map (fun entry ->
            let (countryIsoCode, countryName, dateStr, deathsPerMillion)
                = entry

            let date = DateTime.Parse(dateStr)

            (countryIsoCode, countryName, date, deathsPerMillion))
        |> Seq.sortBy (fun (isoCode, _, _, _) -> isoCode)
        |> Seq.groupBy (fun (isoCode, countryName, _, _)
                         -> (isoCode, countryName))
        |> Seq.map (fun ((isoCode, countryName), countryLines) ->
            let dailyEntries =
                countryLines
                |> Seq.map(fun (_, _, date, deathsPerMillion) ->
                    (date, deathsPerMillion) )
                |> Seq.toArray
                |> (movingAverages
                        movingAverageCentered daysOfMovingAverage
                        (fun (day, _) -> day) (fun (_, value) -> value))
            { CountryIsoCode = isoCode
              CountryName = countryName
              Data = dailyEntries }
            )

    countriesData
    |> Seq.map (fun x -> (x.CountryIsoCode, x))
    |> Map.ofSeq
