# MDI_App
Проект для видео на ютубе

-------------------------------------ХРАНИМЫЕ ПРОЦЕДУРЫ-------------------------------------   
<details><summary>ДОБАВЛЕНИЕ:</summary>   
ALTER PROCEDURE [dbo].[ИМЯ_ВАШЕЙ_ПРОЦЕДУРЫ]    
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,    
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ    
AS   
BEGIN   
	SET NOCOUNT ON;   
	INSERT ИМЯ_ТАБЛИЦЫ (ПОЛЕ_ТАБЛИЦЫ1, ПОЛЕ_ТАБЛИЦЫ2) VALUES (@ИМЯ_ПАРАМЕТРА1, @ИМЯ_ПАРАМЕТРА2)   
END   
</details>   
<details><summary>ОБНОВЛЕНИЕ:</summary>      
ALTER PROCEDURE [dbo].[Update_Акт]   
  @КОД ТИП_ДАННЫХ,
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,    
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ  
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE ИМЯ_ТАБЛИЦЫ SET ПОЛЕ_ТАБЛИЦЫ1 = @ИМЯ_ПАРАМЕТРА1, ПОЛЕ_ТАБЛИЦЫ2 = @ИМЯ_ПАРАМЕТРА2, 
	WHERE КОД_ЗАПИСИ = @КОД
END
</details>
<details><summary>УДАЛЕНИЕ:</summary>     
ALTER PROCEDURE [dbo].[Delete_План]
	-- Add the parameters for the stored procedure here
	@IdPlan int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE План WHERE Код_плана = @IdPlan
END
</details> 
