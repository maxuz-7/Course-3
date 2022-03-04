#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;

out vec3 Normal;
out vec3 Position;
out float visibility;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform vec3 camPos;
const float d = 0.25f;
const float density = 0.007;
const float gradient = 0.005;
void main(){
	vec4 posrestocam = view * model * vec4(aPos, 0.5f);
	Normal = mat3(transpose(inverse(model)))*aNormal;
	Position = vec3(model * vec4(aPos, 1.0f));    
	gl_Position = projection * view * model * vec4(aPos, 1.0);
	vec3 camFrag = aPos - camPos;
	float distance = length(camPos);
	visibility = 1;
}
