﻿using EmployeesApp.Validation;

namespace Tests.Validation;

public class AccountNumberValidationTests
{
    private readonly AccountNumberValidation _validation;

    public AccountNumberValidationTests() => _validation = new AccountNumberValidation();

    [Fact]
    public void IsValid_ValidAccountNumber_ReturnsTrue()
        => Assert.True(_validation.IsValid("123-4543234576-23"));
}