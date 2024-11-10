﻿namespace WebApi8.Models
{
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool status { get; set; } = true;
    }
}