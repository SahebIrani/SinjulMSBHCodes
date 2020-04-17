<Query Kind="Statements">
  <Connection>
    <ID>df24f7fb-cc92-4f72-8f39-d6b8350e03f3</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>SINJULMSBH\MSSQLSERVERS2019</Server>
    <Database>LinqPadDemoDB</Database>
    <ConvertUnderscoresToPascal>true</ConvertUnderscoresToPascal>
    <AlphabetizeColumns>true</AlphabetizeColumns>
    <Persist>true</Persist>
    <DisplayName>LinqPadDemoDB</DisplayName>
    <DriverData>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

//Expression
SinjulMSBHs.AsNoTracking()
	.Include(s => s.JackSlaters)
	.Where(s => s.Id < 80)
	.Where(s => s.IsActive)
	.Where(s => s.Age > 4 && s.Age < 22)
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
	
	
	
	
//Statement
string fullName = "SinjulMSBH";

IEnumerable<SinjulMSBH> result = await SinjulMSBHs
	.Include(s => s.JackSlaters)
	.Where(s => s.Id < 80)
	.Where(s => s.IsActive)
	.Where(s => s.Age > 4 && s.Age < 22)
	.Where(s => s.FullName == fullName)
	.OrderByDescending(s => s.Id)
	.ThenBy(s => s.Age)
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