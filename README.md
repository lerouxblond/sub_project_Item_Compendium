# Item Compendium Sub-Project

The **Item Compendium** is a standalone sub-project aimed at creating a system to catalog and manage all items for a game. It serves as a foundation for efficiently organizing and displaying items by type, providing a dynamic and user-friendly interface for developers and players alike.

## Features

### 1. **Scriptable Object Item Template**

- **Purpose**: Standardize item creation and management.
- **Details**:
  - Each item is a Scriptable Object that includes essential attributes such as:
    - Name
    - Description
    - Icon
    - Item Type (e.g., Consumables, Armor, Weapons, etc.)
    - Specific Stats based on type (e.g., Durability, Hunger Regain, Health Boost).

### 2. **Dynamic UI for Item Display**

- **Purpose**: Display all items in a visually organized manner.
- **Details**:
  - Items are displayed in a scrollable grid layout.
  - Categorization by type (e.g., Consumables, Armor, Weapons) for easy navigation.
  - Sorting options by:
    - Alphabetical Order
    - Item Type
    - Custom Criteria.

### 3. **Slot Script Template**

- **Purpose**: Represent individual item slots in the UI.
- **Details**:
  - Displays the item’s icon and name.
  - Can dynamically adapt to different item types and their associated data.

### 4. **Item Interaction**

- **Purpose**: Provide detailed information and interactivity.
- **Details**:
  - Clicking on an item displays its data in an information panel.
  - Data includes:
    - Name
    - Description
    - Stats
    - Icon
  - Room for future enhancements such as editing or marking items.

### 5. **Search Functionality**

- **Purpose**: Enable quick item lookup.
- **Details**:
  - Search bar dynamically filters items by name or keywords.
  - Updates the displayed grid in real-time as the user types.

### 6. **Audio Feedback**

- **Purpose**: Enhance user experience through sound effects.
- **Details**:
  - Customizable sound effects on item clicks or interactions.

### 7. **Scalable Design**

- **Purpose**: Prepare for future expansions.
- **Details**:
  - Supports large datasets of items without performance degradation.
  - Scrollbars dynamically adjust based on the number of items.

## How to Use

1. **Add Items**:

   - Create new Scriptable Objects based on the Item template.
   - Populate the fields with relevant data.
   - Place them in the `Resources/Items` folder or a subfolder.

2. **UI Setup**:

   - Ensure the grid and slot prefabs are in the scene.
   - Assign the relevant UI elements to the Item Compendium Manager.

3. **Search & Interaction**:

   - Type in the search bar to filter items.
   - Click items in the grid to view their details.

## Conclusion

The **Item Compendium** is a versatile and essential tool for managing in-game items. By providing a centralized system for item data and an intuitive interface, it reduces development time and enhances user experience. Perfect as a base for inventory or crafting systems.

