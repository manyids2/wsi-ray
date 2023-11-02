#version 330

// Input vertex attributes (from vertex shader)
in vec2 fragTexCoord;
in vec4 fragColor;

// Input uniform values
uniform sampler2D texture0;
uniform vec4 colDiffuse;

// Output fragment color
out vec4 finalColor;

// NOTE: Render size values should be passed from code
const float renderWidth = 800;
const float renderHeight = 450;

float radius = 250.0;
float angle = 0.8;

// NOTE: center is connected to the golang code
uniform vec2 center = vec2(200.0, 200.0);

void main()
{
    vec2 texSize = vec2(renderWidth, renderHeight);
    vec2 tc = fragTexCoord*texSize;
    tc -= center;
    float dist = length(tc);
    tc += center;
    vec4 color = texture(texture0, tc/texSize)*colDiffuse*fragColor;;

    finalColor = vec4(color.rgb, 1.0);;
}
