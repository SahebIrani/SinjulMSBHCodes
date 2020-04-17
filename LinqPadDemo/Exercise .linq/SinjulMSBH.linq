<Query Kind="Expression">
  <Connection>
    <ID>593e4eba-044a-4c0f-bdbe-7a5a090e0ff6</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>SINJULMSBH\MSSQLSERVERS2019</Server>
    <Database>LinqPadDemoDB</Database>
    <AlphabetizeColumns>true</AlphabetizeColumns>
    <ConvertUnderscoresToPascal>true</ConvertUnderscoresToPascal>
    <DisplayName>LinqPadDemoDB</DisplayName>
    <DriverData>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

//Expression
await SinjulMSBHs
	.Include(s => s.JackSlaters)
	.Where(s => s.Id < 80  && s.IsActive)
	.Where(s => s.FullName == "SinjulMSBH")
		.OrderByDescending(s => s.Id)
	.Select(s => new {
		s.Id,
		s.FullName,
		s.Age,
		s.IsActive,
		s.BirthDate,
		s.JackSlaters,
	})
	.ToListAsync()
	
	
	
	
//Statement
string fullName = "SinjulMSBH";

IEnumerable<SinjulMSBH> result = await SinjulMSBHs
	.Include(s => s.JackSlaters)
	.Where(s => s.Id < 80  && s.IsActive)
	.Where(s => s.FullName == fullName)
		.OrderByDescending(s => s.Id)
	.Select(s => new SinjulMSBH {
		Id = s.Id,
		FullName = s.FullName,
		Age = s.Age,
		IsActive = s.IsActive,
		BirthDate = s.BirthDate,
		JackSlaters = s.JackSlaters,
	})
	.ToListAsync();
	
result.Dump();