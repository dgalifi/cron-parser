#!/bin/bash

# STOPPING CONTAINER if already running
if [[ "$(docker ps -q -f name=cron-parser-tests 2> /dev/null)" != "" ]]; then
    docker stop cron-parser-tests
fi

# REMOVING CONTAINER if existing
if [[ "$(docker ps -q -a -f name=cron-parser-tests 2> /dev/null)" != "" ]]; then
    docker rm cron-parser-tests
fi

docker build -f Dockerfile-tests -t cron-parser-tests --no-cache .

docker run --name cron-parser-tests cron-parser-tests 