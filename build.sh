#!/bin/sh

set -e

(cd ./MyMonoProj && ./docker-build.sh compile)
docker-compose build