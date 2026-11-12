var environment =
    Environment.GetEnvironmentVariable("APP_ENV")
    ?? "development";

Console.WriteLine(
    $"DevOps Portfolio started in {environment} environment."
);