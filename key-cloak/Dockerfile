FROM quay.io/keycloak/keycloak:26.5.6

ENV KC_BOOTSTRAP_ADMIN_USERNAME=admin
ENV KC_BOOTSTRAP_ADMIN_PASSWORD=admin

# Render requires this
ENV KC_HTTP_PORT=10000

EXPOSE 10000

ENTRYPOINT ["/opt/keycloak/bin/kc.sh", "start-dev", "--http-port=10000", "--hostname-strict=false"]