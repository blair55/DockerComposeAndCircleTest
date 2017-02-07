#!/bin/sh

set -e

(cd ./backend && ./docker-build.sh compile)
docker-compose build