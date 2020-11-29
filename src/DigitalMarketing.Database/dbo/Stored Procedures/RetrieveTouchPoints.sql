
CREATE PROCEDURE [dbo].[RetrieveTouchPoints]
	-- Tenant ID
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT CustomerId,
		CASE
			WHEN JSON_VALUE([Description], '$.EventType')='0' THEN 'AskQuestion'
			WHEN JSON_VALUE([Description], '$.EventType')='1' THEN 'Type 1'
			WHEN JSON_VALUE([Description], '$.EventType')='2' THEN 'Type 2'
			WHEN JSON_VALUE([Description], '$.EventType')='3' THEN 'Type 3'
			WHEN JSON_VALUE([Description], '$.EventType')='4' THEN 'Type 4'
			ELSE 'Unknown'
		END AS [Type],
		JSON_VALUE([Description],'$.PersonalInformation.FirstName') AS 'FirstName',
		JSON_VALUE([Description],'$.PersonalInformation.LastName') AS 'LastName',
		JSON_VALUE([Description],'$.ContactInformation.Email')  AS 'Email',
		JSON_VALUE([Description],'$.ContactInformation.Phone')  AS 'Phone',
		JSON_VALUE([Description],'$.CustomData.Message')  AS 'Question',
		p.Name AS 'Product'
	FROM [dbo].[Touchpoint] tp LEFT JOIN
			[dbo].[Product] p ON JSON_VALUE([Description],'$.CustomData.ProductId')=p.Id
	WHERE ISJSON([Description]) > 0

END
