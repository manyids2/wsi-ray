#version 330 core
layout (location = 0) in vec2 aPos;

# uniform vec2 windowSize;
# uniform vec3 viewState;

const vec2 windowSize = vec2(840.0, 680.0);
const vec3 viewState = vec3(840.0, 680.0, 1.0);

void main()
{
   vec2 offset = aPos * viewState.z + viewState.xy;
   vec2 onScreen = ((offset / windowSize) * 2 ) - 1;
   gl_Position = vec4(onScreen.x, -onScreen.y, 0.0, 1.0);
}
