# Subject

The session's subject.


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `Id`                                                | *string*                                            | :heavy_minus_sign:                                  | The identifier of the subject.                      | 9578-6000-4-48855                                   |
| `IdpId`                                             | *string*                                            | :heavy_minus_sign:                                  | The idp identifier of the subject.                  | 9578-6000-4-48855                                   |
| `Name`                                              | *string*                                            | :heavy_minus_sign:                                  | The full name of the subject.                       | John Doe                                            |
| `FirstName`                                         | *string*                                            | :heavy_minus_sign:                                  | The first name of the subject.                      | John                                                |
| `MiddleName`                                        | *string*                                            | :heavy_minus_sign:                                  | The middle name of the subject.                     | Louis                                               |
| `LastName`                                          | *string*                                            | :heavy_minus_sign:                                  | The last name of the subject.                       | Doe                                                 |
| `DateOfBirth`                                       | *string*                                            | :heavy_minus_sign:                                  | The date of birth of the subject.                   | 2002-06-01                                          |
| `Nin`                                               | [Nin](../../Models/Components/Nin.md)               | :heavy_minus_sign:                                  | The subject's National Identity Number information. |                                                     |
| `Email`                                             | *string*                                            | :heavy_minus_sign:                                  | The Email of the subject.                           | john_doe@mail.com                                   |
| `Attribute1`                                        | *object*                                            | :heavy_minus_sign:                                  | Example idp attribute                               | random_attr                                         |
| `Attribute2`                                        | *object*                                            | :heavy_minus_sign:                                  | Example idp attribute                               | random_attr_4                                       |