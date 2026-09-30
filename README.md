# Prototype Pattern - Robotic Factory System

A C# Console Application demonstrating the **Prototype Design Pattern** in a robotic manufacturing context. This application simulates a factory system capable of cloning existing robot models and customizing their specifications on demand.

## Scenario Overview

In a robotic factory system, creating complex robot instances from scratch for every customer order can be inefficient. By utilizing the **Prototype Pattern**, the factory maintains base prototype models and creates new instances via cloning. Once cloned, unique configurations (such as battery capacity upgrades or software updates) are applied directly.

## Design Pattern Structure

* **Abstract Prototype (`RobotPrototype.cs`)**: Declares the cloning interface (`Clone()`) and defines common properties across all robots.
* **Concrete Prototypes**:
  * `ServiceRobot.cs`: Handles hospitality and healthcare tasks.
  * `IndustrialRobot.cs`: Handles manufacturing tasks such as welding and assembly.
  * `EntertainmentRobot.cs`: Handles event and theme park interactions.
* **Client (`Program.cs`)**: Instantiates base prototypes, performs shallow copies via cloning, and customizes specific properties.

## Features & Attributes

* **Common Attributes**:
  * `ModelName`: Identifier string for the robot model.
  * `BatteryCapacity`: Battery life measured in hours.
  * `SoftwareVersion`: Installed firmware/software version.
  * `Task`: Specific task assigned to the robot instance.
* **Efficient Cloning**: Uses `MemberwiseClone()` to duplicate instances without re-initializing base configurations from scratch.

## Prerequisites

* **IDE**: Visual Studio 2019 / 2022 or VS Code
* **Framework**: .NET Framework or .NET 6.0+

## How to Run

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/IrushiCostha/PrototypePattern_RobotFactory.git
