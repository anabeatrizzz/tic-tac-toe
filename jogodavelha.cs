using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha {
  public partial class jogodavelha: Form {
    int jogador = 1;
    int jogadas = 0;

    public jogodavelha() {
      InitializeComponent();
    }

    private void Vencedor() {
      if (jogadas == 9) {
        if (button1.Text == button2.Text && button1.Text == button3.Text) {
          if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") {
            txtMsg.Text = "O jogador X ganhou";
          } else {
            txtMsg.Text = "O jogador O ganhou";
          }
        }

        else if (button4.Text == button5.Text && button4.Text == button6.Text) {
          if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") {
            txtMsg.Text = "O jogador X ganhou";
          } else {
            txtMsg.Text = "O jogador O ganhou";
          }
        }

        else if (button7.Text == button8.Text && button7.Text == button9.Text) {
          if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") {
            txtMsg.Text = "O jogador X ganhou";
          } else {
            txtMsg.Text = "O jogador O ganhou";
          }
        }

        else if (button1.Text == button5.Text && button1.Text == button9.Text) {
          if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") {
            txtMsg.Text = "O jogador X ganhou";
          } else {
            txtMsg.Text = "O jogador O ganhou";
          }
        }

        else if (button3.Text == button5.Text && button3.Text == button7.Text) {
          if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") {
            txtMsg.Text = "O jogador X ganhou";
          } else {
            txtMsg.Text = "O jogador O ganhou";
          }
        }
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if (button1.Text == "") {
        if (jogador == 1) {
          button1.Text = "X";
        } else {
          button1.Text = "O";
        }
      }

      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button2_Click(object sender, EventArgs e) {
      if (button2.Text == "") {
        if (jogador == 1) {
          button2.Text = "X";
        } else {
          button2.Text = "O";
        }
      }

      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button3_Click(object sender, EventArgs e) {
      if (button3.Text == "") {
        if (jogador == 1) {
          button3.Text = "X";
        } else {
          button3.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button4_Click(object sender, EventArgs e) {
      if (button4.Text == "") {
        if (jogador == 1) {
          button4.Text = "X";
        } else {
          button4.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button5_Click(object sender, EventArgs e) {
      if (button5.Text == "") {
        if (jogador == 1) {
          button5.Text = "X";
        } else {
          button5.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button6_Click(object sender, EventArgs e) {
      if (button6.Text == "") {
        if (jogador == 1) {
          button6.Text = "X";
        } else {
          button6.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button7_Click(object sender, EventArgs e) {
      if (button7.Text == "") {
        if (jogador == 1) {
          button7.Text = "X";
        } else {
          button7.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button8_Click(object sender, EventArgs e) {
      if (button8.Text == "") {
        if (jogador == 1) {
          button8.Text = "X";
        } else {
          button8.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }

    private void button9_Click(object sender, EventArgs e) {
      if (button9.Text == "") {
        if (jogador == 1) {
          button9.Text = "X";
        } else {
          button9.Text = "O";
        }

      }
      
      jogadas++;
      Vencedor();
      jogador = jogador * -1;
    }
  }
}