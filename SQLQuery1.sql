SELECT * 
FROM Talks t Inner join Camps c on t.CampId = c.CampId
WHERE c.Moniker = 'ATL2018';