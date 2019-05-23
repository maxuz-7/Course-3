#version 330 core
out vec4 FragColor;

in float visibility;
in vec3 TexCoords;

uniform samplerCube skybox;

void main(){    
    FragColor = texture(skybox, TexCoords);
    FragColor = mix (vec4(0.6f, 0.6f, 0.6f, 1.0f), FragColor, visibility);
}
