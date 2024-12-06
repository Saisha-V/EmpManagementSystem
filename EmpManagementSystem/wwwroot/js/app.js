//document.addEventListener("DOMContentLoaded", () => {
//    const employeeTableBody = document.getElementById("employeeTableBody");

//    // Example employee data
//    const employees = [
//        { id: 1, firstName: "John", lastName: "Doe", role: "Developer", manager: "Manager 1" },
//        { id: 2, firstName: "Jane", lastName: "Smith", role: "Tester", manager: "Manager 2" }
//    ];

//    // Function to populate the employee table
//    function loadEmployees() {
//        employeeTableBody.innerHTML = ""; // Clear previous rows
//        employees.forEach((employee) => {
//            const row = document.createElement("tr");

//            row.innerHTML = `
//                <td>${employee.id}</td>
//                <td>${employee.firstName}</td>
//                <td>${employee.lastName}</td>
//                <td>${employee.role}</td>
//                <td>${employee.manager}</td>
//                <td>
//                    <button class="edit-button">Edit</button>
//                    <button class="delete-button">Delete</button>
//                </td>
//            `;
//            employeeTableBody.appendChild(row);
//        });
//    }

//    // Initialize the employee table
//    loadEmployees();
//});
