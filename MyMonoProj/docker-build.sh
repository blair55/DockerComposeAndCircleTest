#!/bin/sh

set -e

docker run -v $PWD:/MyMonoProj -w /MyMonoProj mono ./build.sh $@