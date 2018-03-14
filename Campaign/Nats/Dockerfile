FROM sixeyed/nats as base

FROM microsoft/windowsservercore:1709

ENV NATS_DOCKERIZED=1

COPY --from=base /gnatsd/ /gnatsd/

WORKDIR c:/gnatsd

# Expose client, management, and cluster ports
EXPOSE 4222 8222 6222

ENTRYPOINT ["gnatsd"]
CMD ["-c", "gnatsd.conf"]