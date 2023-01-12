using FileEncryptDecrypt.Services.Messages;
using FileEncryptDecrypt.Services.Validator;
using FileEncryptDecrypt.Utils.Interfaces;
using Xunit;

namespace FileEncryptDecryptTests
{
    public class PasswordValidatorTest
    {
        IPasswordValidator _passwordValidator;
        string passwordEmpty = "";
        public PasswordValidatorTest()
        {
            _passwordValidator = new PasswordValidator();

        }

        [Theory]
        //arrange
        [InlineData("abc", "abc", "")]
        [InlineData("", "abc", "WARNING: Password is Empty!")]
        [InlineData("abc", "", "WARNING: Confirm Password is Empty!")]
        [InlineData("abc","def", "WARNING: Password and Confirm Password are discrepant!")]
        public void ComparePasswords_InsertInputs(string password, string confirmPassword, string expected)
        {
            //Act
            var actual = _passwordValidator.ComparePasswords(password, confirmPassword);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
