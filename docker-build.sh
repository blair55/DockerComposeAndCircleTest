#!/bin/sh

set -e

docker run -v $PWD:/backend mono mono --version