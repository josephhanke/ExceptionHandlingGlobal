using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExceptionHandling.Domain;


namespace ExceptionHandling
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void okButton_Click(object sender, EventArgs e)
        {
            string result = "";


            try
            {
                // Calculate percentage of wins:
                decimal wins = decimal.Parse(gamesWonTextBox.Text);
                decimal total = decimal.Parse(totalGamesTextBox.Text);
                decimal winningPercentage = wins / total;

                result = string.Format("Winning Percentage: {0:P}",
                    winningPercentage);

                var monster = new Character() { Name = "Zerg", HitPoints = 3};
                var hero = new Character() { Name = "Buzz", HitPoints = 5 };
                GameActions.Battle(hero, monster);
                result += string.Format("{0} attacked {1} leaving him with {2} hit points.",
                    hero.Name,
                    monster.Name,
                    monster.HitPoints);
            }


            catch(ArgumentOutOfRangeException)
            {
                result = ("Either the attacker or defender are already dead");
            }

            catch (DivideByZeroException)
            {

                result = ("Please enter a value greater than zero for games played.");
            }


            catch (Exception ex)
            {
                result = ("There was a problem:" +ex.Message);

            }
            

            resultLabel.Text = result;
        }

        protected void doNotClick_Click(object sender, EventArgs e)
        {
            ExampleMethods.SomeMethod();
        }

        protected void argumentOutOfRangeButton_Click(object sender, EventArgs e)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    
   
    }

