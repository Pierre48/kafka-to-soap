docker-compose up -d
curl -X POST -H "Content-Type: application/json" --data "@config/http-connect-source.json" http://localhost:8083/connectors
