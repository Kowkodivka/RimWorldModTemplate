#!/bin/bash
find . -type d -name "Assemblies" -exec rm -rf {} \;
dotnet build 1.6/Source
