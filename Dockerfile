########################################
# builder image
########################################
FROM docker.pkg.github.com/treker-mk/docker-base/web-base:latest AS builder
ADD . /app
RUN yarn
RUN NODE_ENV=production CADDY_BUILD=1 yarn build

########################################
# webserver image
########################################
FROM caddy:2.0.0-rc.3-alpine

WORKDIR /app
COPY --from=builder /app/dist /app
COPY Caddyfile /etc/caddy/Caddyfile