## requires https://openapi-generator.tech
openapi-generator generate \
  -g csharp-netcore \
  -i https://raw.githubusercontent.com/Opdex/opdex-v1-api/main/docs/openapi.yml \
  -o opdex-v1-sdk-csharp\
  -p targetFramework=net6.0,netCoreProjectFile=true,packageName=Opdex.Client,packageVersion="1.0.0-alpha7",packageAuthors="Opdex Contributors",packageCompany="",packageDescription="API Client for the V1 Opdex API",packageTags="opdex;defi;stratis;cirrus;blockchain",licenseId=MIT \
  --git-host github.com \
  --git-user-id Opdex \
  --git-repo-id opdex-v1-sdk-csharp \
  --library httpclient