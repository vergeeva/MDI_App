# MDI_App
Проект для видео на ютубе

### ХРАНИМЫЕ ПРОЦЕДУРЫ:
<details><summary>ДОБАВЛЕНИЕ:</summary>   
ALTER PROCEDURE [dbo].[ИМЯ_ВАШЕЙ_ПРОЦЕДУРЫ]   <br>
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,    <br>
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ  <br>  
AS   <br>
BEGIN   <br>
	SET NOCOUNT ON;   <br>
	INSERT ИМЯ_ТАБЛИЦЫ (ПОЛЕ_ТАБЛИЦЫ1, ПОЛЕ_ТАБЛИЦЫ2) VALUES (@ИМЯ_ПАРАМЕТРА1, @ИМЯ_ПАРАМЕТРА2)   <br>
END   <br>
</details>   
<details><summary>ОБНОВЛЕНИЕ:</summary>      
ALTER PROCEDURE [dbo].[Update_Акт] <br>
	@КОД ТИП_ДАННЫХ,<br>
	@ИМЯ_ПАРАМЕТРА1 ТИП_ДАННЫХ,  <br>  
	@ИМЯ_ПАРАМЕТРА2 ТИП_ДАННЫХ  <br>
AS <br>
BEGIN <br>
	SET NOCOUNT ON; <br>
	UPDATE ИМЯ_ТАБЛИЦЫ SET ПОЛЕ_ТАБЛИЦЫ1 = @ИМЯ_ПАРАМЕТРА1, ПОЛЕ_ТАБЛИЦЫ2 = @ИМЯ_ПАРАМЕТРА2, <br>
	WHERE КОД_ЗАПИСИ = @КОД <br>
END <br>
</details>
<details><summary>УДАЛЕНИЕ:</summary>     
ALTER PROCEDURE [dbo].[Delete_План] <br>
	@КОД ТИП_ДАННЫХ,<br>
AS <br>
BEGIN <br>
	SET NOCOUNT ON; <br>
	DELETE ИМЯ_ТАБЛИЦЫ WHERE WHERE КОД_ЗАПИСИ = @КОД <br>
END <br>
</details> 
### СХЕМА ДАННЫХ <br>
![image](https://github.com/vergeeva/MDI_App/assets/61785118/981f4cfd-5943-46e5-9f1e-a4b4c18d08a3)

