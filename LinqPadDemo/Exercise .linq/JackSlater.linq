<Query Kind="Expression">
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

from j in JackSlaters.AsNoTracking()
where j.Id > 310 && j.Age > 4 && j.Age < 22
orderby j.Id descending
select new
{
	j.Id,
	j.SinjulMSBHId,
	j.FullName,
	j.Age,
	j.IsActive,
	j.BirthDate,
}