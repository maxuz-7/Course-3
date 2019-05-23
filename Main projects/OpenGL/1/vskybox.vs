/*#version 330 core
layout (location = 0) in vec3 aPos;

out vec3 TexCoords;
//
out float visibility;

 
uniform mat4 projection;
uniform mat4 view;
//
uniform vec3 camPos;
const float density = 0.17;
const float gradient = 0.05;
void main(){
	vec4 posrestocam = view * vec4(aPos, 0.5);
	TexCoords = aPos;
	vec4 pos = projection * view * vec4(aPos, 1.0);
	gl_Position = pos.xyww;
	vec3 camFrag = aPos - camPos;
	float distance = length(camFrag);
	visibility = density * exp(-camPos.z*gradient)*(1.0f - exp(-distance * camFrag.z*gradient))/(gradient * camFrag.z);
}*/

#version 330 core
layout (location = 0) in vec3 aPos;

out vec3 TexCoords;
//
out float visibility;

const float density = 0.27;
const float gradient = 1.5;

uniform mat4 projection;
uniform mat4 view;
//
uniform vec3 camPos;
//const float density = 0.17;
//const float gradient = 0.25;
const float d = 0.25f;
void main(){
	vec4 posrestocam = view * vec4(aPos, 0.5f);
	TexCoords = aPos;
	gl_Position = projection * view * vec4(aPos, 1.0);
	vec3 camFrag = aPos - camPos;
	float distance = length(camPos);
	visibility = d * exp(-pow((distance*density), 2));
	visibility = clamp (visibility, 0.0, 1.0f);
}
