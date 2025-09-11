## Quickstart

```csharp
var options = new DarenaHealthClientOptions(
    clientId: "client_id",
    clientSecret: "client_secret",
    scope: "meldrx-api patient/*.*"
);

var client = new DarenaHealthClient(options);

var response = await client.Import.ImportPatientEncounterAsync(
    "workspace_slug",
    new(
        new Patient()
        {
            Id = "patient-1",
            Name = new Name("Foo", "Bar"),
            Gender = Gender.Male,
            Dob = new DateTime(2000, 01, 01)
        },
        new Encounter() {
            Id = "encounter-1",
            PatientId = "patient-1",
            CptCodes = [
                new CodeValue("99213", CodingSystem.Icd10)
            ]
        }
    )
);
```
