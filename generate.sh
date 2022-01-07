## requires https://openapi-generator.tech
openapi-generator generate \
  -g csharp-netcore \
  -i https://raw.githubusercontent.com/Opdex/opdex-v1-api/feature/PAPI-314_OASFile/docs/openapi.yml \
  -o opdex-v1-api-csharp \
  -p targetFramework=net6.0,netCoreProjectFile=true,packageName=Opdex.Client