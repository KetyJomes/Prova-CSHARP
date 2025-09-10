namespace Tours.UseCase.Login;

public class LoginUseCasa(
     IJWTService jWTService
)

 public async Task<Result<LoginResponse>> Do(LoginPayload payload)
{
    var user = await userService.FindByLogin(payload.Login);
    if (user is null) 
       return Result<LoginResponse>.Fail("User not found");
    var passwordMatch = passwordService 
            .Compare(payload.Password, user.Password);