import csv
import random
from faker import Faker
from datetime import datetime, timedelta

fake = Faker('en_IN')

NUM_ROWS = 5000

DEPARTMENT_IDS = list(range(1, 26))
ROLE_IDS = list(range(1, 26))

def generate_employee():
    gender = random.choice(['M', 'F'])

    if gender == 'M':
        first_name = fake.first_name_male()
    else:
        first_name = fake.first_name_female()

    last_name = fake.last_name()

    email = f"{first_name.lower()}.{last_name.lower()}{random.randint(100,9999)}@wms.com"

    phone = f"{random.randint(6,9)}{random.randint(100000000,999999999)}"

    dob = fake.date_between(
        start_date='-45y',
        end_date='-21y'
    )

    doj = fake.date_between(
        start_date='-5y',
        end_date='today'
    )

    department_id = random.choice(DEPARTMENT_IDS)

    role_id = random.choice(ROLE_IDS)

    status = random.choice([
        'Active',
        'Active',
        'Active',
        'Active',
        'Inactive'
    ])

    return [
        first_name,
        last_name,
        email,
        phone,
        gender,
        dob,
        doj,
        department_id,
        role_id,
        status
    ]

with open(
    'WMS_5000_Employees.csv',
    'w',
    newline='',
    encoding='utf-8'
) as file:

    writer = csv.writer(file)

    writer.writerow([
        'FirstName',
        'LastName',
        'Email',
        'PhoneNumber',
        'Gender',
        'DateOfBirth',
        'DateOfJoining',
        'DepartmentId',
        'RoleId',
        'Status'
    ])

    for _ in range(NUM_ROWS):
        writer.writerow(generate_employee())

print("✅ WMS_5000_Employees.csv generated successfully!")