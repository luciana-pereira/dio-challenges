/*
Aula: Programa��o Orientada a Objetos - Estrutura b�sica da OO - M�todo

Defina um m�todo para calcular o valor total para encher o tanque. 
Este deve receber como par�metro o valor da gasolina. Fa�a tamb�m 
duas sobrecargas do construtor.
*/
class Car {

	String color;
	String model;
	int tankCapacity;

	Car() {

	}

	Car(String color, String model, int tankCapacity) {
		this.color = color;
		this.model = model;
		this.tankCapacity = tankCapacity;
	}

	void setColor(String color) {
		this.color = color;
	}

	String getColor() {
		return color;
	}

	void setModel(String model) {
		this.model = model;
	}

	String getModel() {
		return model;
	}

	void setTankCapacity(int tankCapacity) {
		this.tankCapacity = tankCapacity;
	}

	int getTankCapacity() {
		return tankCapacity;
	}

	double totalTankValue(double fuelValue) {
		return tankCapacity * fuelValue;
	}
}