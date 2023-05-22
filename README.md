# Medical Clinic System

This application is a small example of Medical Clinic System

## Technologies

- .NET Core 5.0
- ASP.NET
- Entity Framework
- SQL Server
- Docker

## Getting Started

1. Run Application

2. Exemple of Creating Patient:

```bash
curl -X 'POST' \
  'https://localhost:7265/api/v1/patients' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "name": "John Wick",
  "mother_name": "Mari Wick",
  "date_of_birth": "1973-05-01",
  "gender": "M",
  "medication_allergy": true,
  "medication_allergy_description": "Aspirina",
  "created_at": "2023-05-22T03:50:38.781Z",
  "updated_at": "2023-05-22T03:50:38.781Z"
}'
```