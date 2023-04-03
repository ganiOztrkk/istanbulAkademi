using Microsoft.AspNetCore.Identity;

namespace SpryStore.PresentationLayer.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
				{ Code = "PasswordRequiresLower", Description = "Lütfen En Az 1 Küçük Harf Girişi Yapınız." };
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
				{ Code = "PasswordRequiresUpper", Description = "Lütfen En Az 1 Büyük Harf Girişi Yapınız." };
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
				{ Code = "PasswordRequiresDigit", Description = "Lütfen En Az 1 Rakam Girişi Yapınız." };
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
				{ Code = "PasswordRequiresNonAlphanumeric", Description = "Lütfen En Az 1 Sembol Girişi Yapınız." };
		}

		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
				{ Code = "PasswordTooShort", Description = "Lütfen En Az 8 Karakter Girişi Yapınız." };
		}
	}
}
