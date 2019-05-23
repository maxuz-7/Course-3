#version 330 core
layout (location = 0) in vec3 aPos;

out vec3 TexCoords;
out float visibility;

uniform mat4 projection;
uniform mat4 view;
uniform vec3 camPos;

const float d = 0.25f;
const float density = 0.007;
const float gradient = 0.005;

void main(){
    TexCoords = aPos;
    vec4 pos = projection * view * vec4(aPos, 1.0);
    gl_Position = pos.xyww;
    float distance = length(camPos);
    visibility = 1;
}
