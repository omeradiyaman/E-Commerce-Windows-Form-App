﻿// <auto-generated />
using System;
using E_Commerce.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce.Persistence.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20241030105256_ChangedEntities")]
    partial class ChangedEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce.Domain.Entities.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountId"));

                    b.Property<float>("DiscountPercentage")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DiscountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductCategoryId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipmentId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShipmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipmentStatus")
                        .HasColumnType("int");

                    b.Property<string>("TrackingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipmentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Wishlist", b =>
                {
                    b.Property<int>("WishlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishlistId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WishlistId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.WishlistItem", b =>
                {
                    b.Property<int>("WishlistItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishlistItemId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WishlistId")
                        .HasColumnType("int");

                    b.HasKey("WishlistItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WishlistId");

                    b.ToTable("WishlistItems");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Cart", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Discount", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Order", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.Product", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId1");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Payment", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("E_Commerce.Domain.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Review", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Shipment", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Order", "Order")
                        .WithOne("Shipment")
                        .HasForeignKey("E_Commerce.Domain.Entities.Shipment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Wishlist", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.User", "User")
                        .WithOne("Wishlist")
                        .HasForeignKey("E_Commerce.Domain.Entities.Wishlist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.WishlistItem", b =>
                {
                    b.HasOne("E_Commerce.Domain.Entities.Product", "Product")
                        .WithMany("WishlistItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.Domain.Entities.Wishlist", "Wishlist")
                        .WithMany("WhislistItems")
                        .HasForeignKey("WishlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Wishlist");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payment")
                        .IsRequired();

                    b.Navigation("Shipment")
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderDetails");

                    b.Navigation("OrderItems");

                    b.Navigation("ProductCategories");

                    b.Navigation("Reviews");

                    b.Navigation("WishlistItems");
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("Wishlist")
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.Domain.Entities.Wishlist", b =>
                {
                    b.Navigation("WhislistItems");
                });
#pragma warning restore 612, 618
        }
    }
}
