#!/bin/sh

set -e

./docker-build.sh
docker-compose build