# MySql-Projec
//sum by coluns
(
	SELECT
		Date,
		Article_ID,
		Lavoratione_ID,
		Linia_ID,
		No_39,
		No_40,
		No_41,
		No_42,
		No_43,
		No_44,
		No_45,
		No_46,
		Total
	FROM
		manufactured
	WHERE
		Linia_ID = '8'
)
UNION
	(
		SELECT
			"" AS Date,
			"" AS Article_ID,
			"Total as Number:" AS Lavoratione_ID,
			"" AS Linia_ID,
			SUM(No_39) AS No_39,
			SUM(No_40) AS No_40,
			SUM(No_41) AS No_41,
			SUM(No_42) AS No_42,
			SUM(No_43) AS No_43,
			SUM(No_44) AS No_44,
			SUM(No_45) AS No_45,
			SUM(No_46) AS No_46,
			SUM(Total) AS Total
		FROM
			manufactured
		WHERE
			Linia_ID = '8'
	)
//Laves in manufactoring	
SELECT
`leave`.ID,
`leave`.bu_ID,
`leave`.Article_ID,
`leave`.Lavoratione_ID,
`foundo`.F_Name,
`linia`.Linia,
`leave`.No_39,
`leave`.No_40,
`leave`.No_41,
`leave`.No_42,
`leave`.No_43,
`leave`.No_44,
`leave`.No_45,
`leave`.No_46,
`leave`.Total
FROM
foundo
INNER JOIN `leave` ON `leave`.Foundo_ID = foundo.ID
INNER JOIN linia ON `leave`.Linia_ID = linia.ID
WHERE Total > 0;
