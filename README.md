# kafka-to-soap

PoC about a way to plug a kafka topic to a soap endpoint

# Projects : 
* EventSimulator : Push an event in a topic each seconds
* SoapServer : Source file for a container that host a WCF service
* kafka-connect : Dockerfile to build a Docker image with [http sink connector](https://docs.confluent.io/kafka-connect-http/current/index.html

At the root level, you will find a docker-compose that allows to run an one node kafka cluster, and AKHQ to check published events.

# Run the project 
To run the project, you just have to run the following command : 
````
docker-compose up -d
````

Once, everything is build, and launched, you can push the connect configuration to start the test : 
````
curl -X POST -H "Content-Type: application/json" --data "@config/http-connect-source.json" http://localhost:8083/connectors
````
