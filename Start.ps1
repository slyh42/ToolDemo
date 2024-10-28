$count = 0
while($true)
{
	Write-host "Count: $count"
	Start-Process -Wait -FilePath "C:\Program Files (x86)\Steam\steamapps\common\Cities Skylines II\Cities2.exe"
	$count++
}