#!/bin/sh

set -e

docker run mono mono --version
docker-compose build