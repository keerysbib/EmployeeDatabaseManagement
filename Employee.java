/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.stuproject.stapp;

/**
 *
 * @author Lenovo
 */
import java.io.Serializable;
import java.time.LocalDate;

public class Employee {
	
	private int id;
	private String name;
	private int  age;
	private String dob;
	private String department;
	private double salary;
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getDesiganation() {
		return dob;
	}
	public void setDesiganation(String desiganation) {
		this.dob = desiganation;
	}
	public String getDepartment() {
		return department;
	}
	public void setDepartment(String department) {
		this.department = department;
	}
	public double getSalary() {
		return salary;
	}
	public void setSalary(double salary) {
		this.salary = salary;
	}
	@Override
	public String toString() {
		return "Employee [id=" + id + ", name=" + name + ", age=" + age + ", desiganation=" + dob
				+ ", department=" + department + ", salary=" + salary + "]";
	}
	public Employee(int id, String name, int age, String dob, String department, double salary) {
		super();
		this.id = id;
		this.name = name;
		this.age = age;
		this.dob = dob;
		this.department = department;
		this.salary = salary;
	}
	
	
	
	
	
	

}