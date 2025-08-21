namespace Eventing.Web.Components.Features.Register.Dtos;

public sealed record RegisterRequestDto(string Name, string Email, string Password,string ConfirmPassword);