using Modes.Interfaces;
using Prism.Mvvm;
using StepInLife.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Modes
{

    public class RegistrationViewModel: BindableBase, System.ComponentModel.IDataErrorInfo
    {
        public RegistrationViewModel()
        {
            model = new RegModel();
        }
        private RegModel model;
        
        public RegModel RegistrationForm
        {
            get
            {
                return model;
            }
            set
            {
                SetProperty(ref model, value);
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "BirthDay":
                        if ((DateTime.Now.Year - model.BirthDay.Year <= 0 ) || (DateTime.Now.Year - model.BirthDay.Year > 100))
                        {
                            error = "Возраст должен быть больше 0 и меньше 100";
                        }
                        break;
                    case "FirstName":
                        {
                            Regex regex = new Regex(@"\d+");
                            MatchCollection matches = regex.Matches(model.FirstName);
                            if (matches.Count != 0)
                                error = "В имени не должно быть цифр";
                            else if (model.FirstName == string.Empty)
                                error = "Все поля должны быть заполнены";
                            else if (model.FirstName.Length > 20)
                                error = "Количество символов в имени не должно превышать 20";
                            
                        }
                        break;
                    case "Surname":
                        {
                            Regex regex = new Regex(@"\d+");
                            MatchCollection matches = regex.Matches(model.Surname);
                            if (matches.Count != 0)
                                error = "В фамилии не должно быть цифр";
                            else if (model.FirstName == string.Empty)
                                error = "Все поля должны быть заполнены";
                            else if (model.FirstName.Length > 20)
                                error = "Количество символов в фамилии не должно превышать 20";

                        }
                        break;
                    case "Email":{
                            bool isEmail = Regex.IsMatch(model.Email,
                                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                            if (!isEmail)
                            {
                                error = "Неккоректно введён емейл";
                            }
                        } break;
                    case "Password": {
                            var input = model.Password;
                           
                            if (string.IsNullOrWhiteSpace(input))
                            {
                                error = ("В пароле не должно содержатся пробелов");
                            }

                            var hasNumber = new Regex(@"[0-9]+");
                            var hasMiniMaxChars = new Regex(@".{4,20}");
                            var hasLowerChar = new Regex(@"[a-z]+");


                            if (!hasLowerChar.IsMatch(input))
                            {
                                error = "Пароль должен иметь хотя бы одну латинскую цифру";
                            }
           
                            else if (!hasMiniMaxChars.IsMatch(input))
                            {
                                error = "Пароль должен быть больше 4 символов и меньше 20";
                            }
                            else if (!hasNumber.IsMatch(input))
                            {
                                error = "Пароль должен иметь хотя бы 1 цифру";

                            }


                        } break;
                }
                return error;
            }
        }

        
        public DateTime BirthDay
        {
            get
            {
                return model.BirthDay;
            }
            set
            {
                if (model.BirthDay == value)
                {
                    return;
                }

                model.BirthDay = value;
                RaisePropertyChanged();
            }
        }


        public string City
        {
            get
            {
                return model.City;
            }
            set
            {
                if (model.City == value)
                {
                    return;
                }

                model.City = value;
                RaisePropertyChanged();
            }
        }

        public string Email {
            get
            {
                return model.Email;
            }
            set
            {
                if (model.Email == value)
                {
                    return;
                }

                model.Email = value;
                RaisePropertyChanged();
            }
        }

        public string FirstName {
            get
            {
                return model.FirstName;
            }
            set
            {
                if (model.FirstName == value)
                {
                    return;
                }

                model.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return model.Password;
            }
            set
            {
                if (model.Password == value)
                {
                    return;
                }

                model.Password = value;
                RaisePropertyChanged();
            }
        }

        public string Specialization {
            get
            {
                return model.Specialization;
            }
            set
            {
                if (model.Specialization == value)
                {
                    return;
                }

                model.Specialization = value;
                RaisePropertyChanged();
            }
        }

        public string Surname
        {
            get
            {
                return model.Surname;
            }
            set
            {
                if (model.Surname == value)
                {
                    return;
                }

                model.Surname = value;
                RaisePropertyChanged();
            }
        }
        private RelayCommand addCommand;
        public RelayCommand AddCommand {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        MessageBox.Show($"{model.FirstName}");
                    }));
            }
        }
    }
}
