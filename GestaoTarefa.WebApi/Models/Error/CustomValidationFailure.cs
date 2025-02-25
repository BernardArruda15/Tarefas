namespace GestaoTarefa.WebApi.Models.Error
{
    public class CustomValidationError
    {
        public CustomValidationError(string proportyName, string errorMessage) 
        {
            PropertyName = proportyName;
            ErrorMessage = errorMessage;
        }  
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
