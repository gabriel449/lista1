//C�digo fonte do Fragment Shader (em GLSL):
#version 400

//Tira o inputColor que tava aqui


//Cria a vari�vel "in"
in vec4 finalColor;
out vec4 color;

void main()
{
	color = finalColor;
}