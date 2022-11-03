# Internexus.Address

## Build image

```
docker build .
```

## Run container


```
docker run -p 8080:80
```

## Create Migrations

```
Add-Migration initial -Context AppDbContext -Project Internexus.Address.Infra -OutputDir Migrations
```