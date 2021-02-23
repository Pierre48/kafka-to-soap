FROM confluentinc/cp-kafka-connect-base AS connect
WORKDIR /usr/share/java
RUN confluent-hub install --no-prompt  confluentinc/kafka-connect-http:latest
