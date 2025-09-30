$source = Get-Content -Path "./_excel_entry.cs"
Add-Type -TypeDefinition "$source"
[ExcelEntry]::Run();