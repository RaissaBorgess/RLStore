namespace RLStore.Helpers;

public static class TranslateIndentityErrors
{
    public static string TranslateErrorMessage(string codeError)
    {
        string message = codeError switch
        {
            "DefaultError" => "Ocorreu um erro desconhecido.",
            "ConcurrencyFailure" => "Falha de concorrência otimista, o objeto foi modificado.",
            "InvalidToken" => "Token inválido",
            "LoginAlreadyAssociated" => "Já existe um usuário com este login.", 
            "InvalidUserName" => $"Este login é inválido, um login deve conter apenas letras ou dígitos.",
            "InvalidEmail" => "Email inválido.", 
            "DuplicateUserName" => "Este login já está sendo utilizado.",
            "DuplicateEmail" => "Este email já está sendo utilizado.",
            "InavlidRoleName" => "Esta permissão pppe invalida.",
            "DuplicateRoleName" => "Esta permissão já está sendo utilizada.",
            "UserAlreadyInRole" => "Usuário já possui esta permissão.",
            "UserNotInRole" => "Usuário não tem permissão.",
            "UserLockoutNotEnabled" => "Lockout não está habilitado para este usuário.",
            "UserALreadyHasPassword" => "Usuário não tem permissão",
            "PasswordMismatch" => "Senha incorreta.",
            "PasswordTooShort" => "Senha muito curta.",
            "PasswordRequiresNonAlphanumeric" => "Senhas devem conter ao menos um caracter não alfanumérico.",
            "PasswordRequiresDigit" => "Senhas devem conter ao menos um digito ('0'-'9).",
            "PasswordRequiresLower" => "Senhas devem conter ao menos um caracter em caixa baixa ('a'-'z').",
            "PasswordRequiresUpper" => "senhas devem conter ao menos um caracter em caixa alta ('A'-'Z').",
            _=> "Ocorreu um erro desconhecido.",
        };
    return message;
    }
}