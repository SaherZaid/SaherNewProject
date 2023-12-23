﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(BookStoresContext))]
    partial class BookStoresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore", b =>
                {
                    b.Property<string>("BooksIsbn13")
                        .HasColumnType("varchar(13)");

                    b.Property<int>("StoresStoreID")
                        .HasColumnType("int");

                    b.HasKey("BooksIsbn13", "StoresStoreID");

                    b.HasIndex("StoresStoreID");

                    b.ToTable("BookStore");
                });

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("Author_id");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("Date_of_Birth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("First_Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Last_Name");

                    b.HasKey("AuthorId")
                        .HasName("Authors_pk");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DataAccess.Entities.AuthorBook", b =>
                {
                    b.Property<int?>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    b.Property<string>("BookId")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("book_id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBooks");
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.Property<string>("Isbn13")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("ISBN13");

                    b.Property<int?>("AuthorNo")
                        .HasColumnType("int")
                        .HasColumnName("Author_no");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date")
                        .HasColumnName("Release_Date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Isbn13")
                        .HasName("PK__Books__3BF79E0300E916DC");

                    b.HasIndex("AuthorNo");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.BooksInventory", b =>
                {
                    b.Property<string>("Booktitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("booktitle");

                    b.Property<string>("Isbn13")
                        .IsRequired()
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("ISBN13");

                    b.Property<int>("NoOfProducts")
                        .HasColumnType("int")
                        .HasColumnName("No_Of_Products");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("Store_id");

                    b.ToTable((string)null);

                    b.ToView("BooksInventory", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.BookstoreInfo", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("First_Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Last_Name");

                    b.Property<int?>("TotalOrdersPrice")
                        .HasColumnType("int");

                    b.Property<int?>("TotalOrdes")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("BookstoreInfo", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("city");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("State")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("street");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("zip_code");

                    b.HasKey("CustomerId")
                        .HasName("PK__Customer__8CB382B1F07522E7");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataAccess.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("address");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("contact_number");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<DateOnly?>("HireDate")
                        .HasColumnType("date")
                        .HasColumnName("hire_date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("position");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("Store_id");

                    b.HasKey("EmployeeId")
                        .HasName("PK__Employee__C52E0BA82528F404");

                    b.HasIndex("StoreId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DataAccess.Entities.InventoryBalance", b =>
                {
                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("Store_id");

                    b.Property<string>("Isbn13")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("ISBN13");

                    b.Property<int>("NoOfProducts")
                        .HasColumnType("int")
                        .HasColumnName("No_Of_Products");

                    b.HasKey("StoreId", "Isbn13")
                        .HasName("PK__Inventor__834F1EF94752277B");

                    b.HasIndex("Isbn13");

                    b.ToTable("InventoryBalance", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("Order_id");

                    b.Property<int?>("CustomerNo")
                        .HasColumnType("int")
                        .HasColumnName("Customer_No");

                    b.Property<DateOnly?>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("Order_date");

                    b.Property<int?>("OrderPrice")
                        .HasColumnType("int")
                        .HasColumnName("Order_Price");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Order_status");

                    b.Property<TimeOnly?>("OrderTime")
                        .HasColumnType("time")
                        .HasColumnName("Order_time");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Order_Type");

                    b.Property<string>("ReferenceNumber")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("Reference_Number");

                    b.Property<int?>("StoreNo")
                        .HasColumnType("int")
                        .HasColumnName("Store_No");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__F1FF8453E1A1211A");

                    b.HasIndex("CustomerNo");

                    b.HasIndex("ReferenceNumber");

                    b.HasIndex("StoreNo");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .HasColumnType("int")
                        .HasColumnName("shift_id");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("ShiftEnd")
                        .HasColumnType("datetime")
                        .HasColumnName("shift_end");

                    b.Property<DateTime>("ShiftStart")
                        .HasColumnType("datetime")
                        .HasColumnName("shift_start");

                    b.HasKey("ShiftId")
                        .HasName("PK__Shifts__7B2672209195BAEE");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("DataAccess.Entities.Store", b =>
                {
                    b.Property<int>("StoreID")
                        .HasColumnType("int")
                        .HasColumnName("Store_iD");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.HasKey("StoreID")
                        .HasName("PK__Stores__A0F0677996872BAB");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("DataAccess.Entities.TitlesPerAuthor", b =>
                {
                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("InventoryValue")
                        .HasColumnType("int")
                        .HasColumnName("Inventory value");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(61)
                        .IsUnicode(false)
                        .HasColumnType("varchar(61)");

                    b.Property<int?>("Titles")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("TitlesPerAuthor", (string)null);
                });

            modelBuilder.Entity("BookStore", b =>
                {
                    b.HasOne("DataAccess.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksIsbn13")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Store", null)
                        .WithMany()
                        .HasForeignKey("StoresStoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.AuthorBook", b =>
                {
                    b.HasOne("DataAccess.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__AuthorBoo__autho__6E01572D");

                    b.HasOne("DataAccess.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__AuthorBoo__book___6EF57B66");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.HasOne("DataAccess.Entities.Author", "AuthorNoNavigation")
                        .WithMany("Books")
                        .HasForeignKey("AuthorNo")
                        .HasConstraintName("FK__Books__Author_no__267ABA7A");

                    b.Navigation("AuthorNoNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Employee", b =>
                {
                    b.HasOne("DataAccess.Entities.Store", "Store")
                        .WithMany("Employees")
                        .HasForeignKey("StoreId")
                        .IsRequired()
                        .HasConstraintName("FK__Employees__Store__5BE2A6F2");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DataAccess.Entities.InventoryBalance", b =>
                {
                    b.HasOne("DataAccess.Entities.Book", "Isbn13Navigation")
                        .WithMany("InventoryBalances")
                        .HasForeignKey("Isbn13")
                        .IsRequired()
                        .HasConstraintName("FK__Inventory__ISBN1__3F466844");

                    b.HasOne("DataAccess.Entities.Store", "Store")
                        .WithMany("InventoryBalances")
                        .HasForeignKey("StoreId")
                        .IsRequired()
                        .HasConstraintName("FK__Inventory__Store__3E52440B");

                    b.Navigation("Isbn13Navigation");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.HasOne("DataAccess.Entities.Customer", "CustomerNoNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerNo")
                        .HasConstraintName("Orders_Customers_FK");

                    b.HasOne("DataAccess.Entities.Book", "ReferenceNumberNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ReferenceNumber")
                        .HasConstraintName("Orders_Books_FK");

                    b.HasOne("DataAccess.Entities.Store", "StoreNoNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("StoreNo")
                        .HasConstraintName("Orders_Orders_FK");

                    b.Navigation("CustomerNoNavigation");

                    b.Navigation("ReferenceNumberNavigation");

                    b.Navigation("StoreNoNavigation");
                });

            modelBuilder.Entity("DataAccess.Entities.Shift", b =>
                {
                    b.HasOne("DataAccess.Entities.Employee", "Employee")
                        .WithMany("Shifts")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK__Shifts__employee__5EBF139D");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.Navigation("InventoryBalances");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Employee", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("DataAccess.Entities.Store", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("InventoryBalances");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
