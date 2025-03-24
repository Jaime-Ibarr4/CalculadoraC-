using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
//using AForge.Video;
//using AForge.Video.DirectShow;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        private SpeechRecognizer? recognizer = null;
        private bool isMicrophoneOn = false;
       // private FilterInfoCollection videoDevices; // Lista de dispositivos de video
       // private VideoCaptureDevice videoSource;   // Fuente de video actual

        public Form1()
        {
            InitializeComponent();
            InitializeSpeechRecognition();
        }

        // Manejadores de eventos para los botones de operadores para agregar operadores al cuadro de entrada
        private void addButton_Click(object sender, EventArgs e) => inputBox.Text += "+";
        private void subtractButton_Click(object sender, EventArgs e) => inputBox.Text += "−"; // Cambiado a "−"
        private void multiplyButton_Click(object sender, EventArgs e) => inputBox.Text += "*";
        private void divideButton_Click(object sender, EventArgs e) => inputBox.Text += "/";
        private void openParenButton_Click(object sender, EventArgs e) => inputBox.Text += "(";
        private void closeParenButton_Click(object sender, EventArgs e) => inputBox.Text += ")";

        // Manejador de eventos para el botón de raíz cuadrada
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputBox.Text, out double num) && num >= 0)
            {
                resultBox.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                resultBox.Text = "Error";
            }
        }

        // Manejador de eventos para el botón de seno
        private void sinButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputBox.Text, out double num))
            {
                resultBox.Text = Math.Sin(num * Math.PI / 180).ToString(); // Convierte a radianes
            }
            else
            {
                resultBox.Text = "Error";
            }
        }

        // Manejador de eventos para el botón de igual para evaluar la expresión
        private void equalsButton_Click(object sender, EventArgs e)
        {
            EvaluateExpression();
        }

        // Manejador de eventos para el botón de borrar para limpiar los cuadros de entrada y resultado
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = string.Empty;
            resultBox.Text = string.Empty;
        }

        // Manejador de eventos para los botones de números para agregar el número al cuadro de entrada
        private void numberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                inputBox.Text += button.Text;
            }
        }

        // Inicializa el reconocimiento de voz
        private void InitializeSpeechRecognition()
        {
            try
            {
                var config = SpeechConfig.FromSubscription("7I5nyLhiV1cgGZjimY1q5ZEAP4yxjUWdvEqDeNI45L50tUjk7lGWJQQJ99BCACYeBjFXJ3w3AAAYACOGcral", "eastus");
                config.SpeechRecognitionLanguage = "es-ES"; // Configura el idioma a español
                recognizer = new SpeechRecognizer(config);

                // Manejador de eventos para el reconocimiento de voz
            recognizer.Recognized += (s, e) =>
            {
                if (e.Result.Reason == ResultReason.RecognizedSpeech)
                {
                    var recognizedText = e.Result.Text.ToLower().Trim();

                    try
                    {
                        if (recognizedText.Contains("igual") || recognizedText.Contains("calcular"))
                        {
                            EvaluateExpression();
                        }
                        else if (recognizedText.Contains("borrar") || recognizedText.Contains("eliminar") || recognizedText.Contains("limpiar"))
                        {
                            clearButton_Click(this, EventArgs.Empty);
                        }
                        else if (recognizedText.Contains("abrir paréntesis") || recognizedText.Contains("abre paréntesis"))
                        {
                            inputBox.Invoke((MethodInvoker)(() => inputBox.Text += "("));
                        }
                        else if (recognizedText.Contains("cerrar paréntesis") || recognizedText.Contains("cierra paréntesis"))
                        {
                            inputBox.Invoke((MethodInvoker)(() => inputBox.Text += ")"));
                        }
                        else if (recognizedText.Contains("seno"))
                        {
                            var numberText = recognizedText.Replace("seno de", "").Trim();
                            if (double.TryParse(numberText, out double num))
                            {
                                inputBox.Invoke((MethodInvoker)(() => inputBox.Text = num.ToString()));
                                resultBox.Invoke((MethodInvoker)(() => resultBox.Text = Math.Sin(num * Math.PI / 180).ToString()));
                            }
                        }
                        else if (recognizedText.Contains("raíz cuadrada de") || recognizedText.Contains("raíz") || recognizedText.Contains("raíz cuadrada"))
                        {
                            var numberText = recognizedText.Replace("raíz cuadrada de", "").Trim();
                            if (double.TryParse(numberText, out double num))
                            {
                                inputBox.Invoke((MethodInvoker)(() => inputBox.Text = num.ToString()));
                                resultBox.Invoke((MethodInvoker)(() => resultBox.Text = Math.Sqrt(num).ToString()));
                            }
                        }
                        else if (recognizedText.Contains("pi"))
                        {
                            inputBox.Invoke((MethodInvoker)(() => inputBox.Text += "3.14159"));
                        }
                        else
                        {
                            inputBox.Invoke((MethodInvoker)(() => inputBox.Text += recognizedText));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar el comando: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };


                // Manejador de eventos para la cancelación del reconocimiento
                recognizer.Canceled += async (s, e) =>
                {
                    if (e.Reason == CancellationReason.Error)
                    {
                        MessageBox.Show($"Error en el reconocimiento de voz: {e.ErrorDetails}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (e.Reason == CancellationReason.EndOfStream && isMicrophoneOn)
                    {
                        await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);
                    }
                };

                // Manejador de eventos para la detención de la sesión
                recognizer.SessionStopped += async (s, e) =>
                {
                    if (isMicrophoneOn)
                    {
                        await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el reconocimiento de voz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador de eventos para el botón de voz para alternar el micrófono
        private async void voiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMicrophoneOn)
                {
                    if (recognizer != null)
                    {
                        await recognizer.StopContinuousRecognitionAsync().ConfigureAwait(false);
                    }
                    MessageBox.Show("El micrófono está apagado.", "Micrófono desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isMicrophoneOn = false;
                    voiceButton.BackColor = Color.Gray; // Cambia el color del botón a gris
                }
                else
                {
                    if (await TestSpeechServiceConnection())
                    {
                        if (recognizer != null)
                        {
                            await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);
                        }
                        MessageBox.Show("El micrófono está encendido. Hable ahora.", "Micrófono activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isMicrophoneOn = true;
                        voiceButton.BackColor = Color.Green; // Cambia el color del botón a verde
                    }
                    else
                    {
                        MessageBox.Show("No se pudo conectar al servicio de reconocimiento de voz.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al manejar el micrófono: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Prueba la conexión al servicio de reconocimiento de voz
        private async Task<bool> TestSpeechServiceConnection()
        {
            try
            {
                var config = SpeechConfig.FromSubscription("7I5nyLhiV1cgGZjimY1q5ZEAP4yxjUWdvEqDeNI45L50tUjk7lGWJQQJ99BCACYeBjFXJ3w3AAAYACOGcral", "eastus");
                config.SpeechRecognitionLanguage = "es-ES"; // Configura el idioma a español
                using var recognizer = new SpeechRecognizer(config);
                var result = await recognizer.RecognizeOnceAsync().ConfigureAwait(false);

                if (result.Reason == ResultReason.RecognizedSpeech || result.Reason == ResultReason.NoMatch)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al probar la conexión: {result.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al probar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Evalúa la expresión en el cuadro de entrada y muestra el resultado en el cuadro de resultado
        private void EvaluateExpression()
        {
            try
            {
                // Reemplaza el símbolo "−" por el guion "-"
                var expression = inputBox.Text.Replace("−", "-");
                var result = new DataTable().Compute(expression, null);
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                resultBox.Text = "Error";
            }
        }
    }
}