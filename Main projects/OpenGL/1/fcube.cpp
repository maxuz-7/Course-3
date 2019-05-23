#version 330 core
out vec4 FragColor;

in vec3 Normal;
in vec3 Position;
in float visibility;

uniform vec3 cameraPos;
uniform samplerCube skybox;

float zNear = 0.1f;
float zFar = 100.0f;
float Linear(float depth){
        float z = depth * 2.0f - 1.0f;
        return (2.0f * zNear *zFar) / (zFar + zNear - z * (zFar - zNear));
}


void main(){    
    	float ratio = 1.00 / 1.309;
    	vec3 I = normalize(Position - cameraPos);
    	vec3 R = refract(I, normalize(Normal), ratio);
    	FragColor = vec4(texture(skybox, R).rgb, 1.0);
	FragColor = mix(vec4(0.5f, 0.5f, 0.5f, 1.0f), FragColor, visibility);
}


