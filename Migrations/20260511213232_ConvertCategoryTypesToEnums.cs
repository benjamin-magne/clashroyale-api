using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClashRoyaleApi.Migrations
{
    /// <inheritdoc />
    public partial class ConvertCategoryTypesToEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_AlliesBuff",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_AlliesSpeedBoost",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_BackwardTeleport",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Barrage",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_BuildingSummon",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Charge",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Clone",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Curse",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_DamageBoost",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_DamageReduction",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Dash",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_DualForm",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_ElixirCollect",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_EnemiesSpeedReduction",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Freeze",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Grab",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Heal",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Invincibility",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Invisible",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Jump",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_KeepMaxDamage",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Knockback",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Mirror",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_MultipleTroops",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_MultiplesDash",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_PullToCenter",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Redeploy",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_ReflectProjectiles",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Resurrect",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SecondaryAttack",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Shield",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SideSwitchTeleport",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Slow",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Snare",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SoulsCollect",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SpellSummon",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Stun",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SwitchToAir",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SwitchToBuilding",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_SwitchToGround",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_Taunt",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Mechanic_TroopSummon",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Movement_Air",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Movement_Ground",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Speed_Fast",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Speed_Medium",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Speed_Slow",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Speed_VeryFast",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Target_Air",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Target_Both",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Target_Buildings",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Target_Ground",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_Activation",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnAttack",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnChargeComplete",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnClick",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnDamageTaken",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnDeath",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnDeploy",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnDurationEnd",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnHit",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_OnTargetReached",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger_Passive",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "TroopType_Building",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "TroopType_Spell",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "TroopType_Troop",
                table: "Troops");

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_TurretHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_ShieldHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_MaxHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_Hitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_DecoyHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_CloneShieldHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Hitpoints_CloneHitpoints",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_WarpDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_TurretDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_TripleShotDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_TornadoDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_SpawnDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_SniperDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_ReflectedTowerDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_ReflectDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_RecoilDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_RangedDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_PushbackDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_PulseDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_PowerShotDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_PoisonDamagePerSecond",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_MeleeDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_LandingDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_JumpDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_IceBlastDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_ExtraChainDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_DeathDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_DashDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_DamagePerSecond",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_DamagePerBlast",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_Damage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_CrownTowerDamagePerSecond",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_CrownTowerDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_ComboDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_CloseQuartersDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_ChargeDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_BuildingDamagePerSecond",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_BounceDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_BonusDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_BarrageDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stats_Damage_AreaDamage",
                table: "Troops",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stats_Mechanic",
                table: "Troops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stats_Movement",
                table: "Troops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stats_Speed",
                table: "Troops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stats_Target",
                table: "Troops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stats_Trigger",
                table: "Troops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TroopType",
                table: "Troops",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stats_Mechanic",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Movement",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Speed",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Target",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Trigger",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "TroopType",
                table: "Troops");

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_TurretHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_ShieldHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_MaxHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_Hitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_DecoyHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_CloneShieldHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Hitpoints_CloneHitpoints",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_WarpDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_TurretDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_TripleShotDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_TornadoDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_SpawnDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_SniperDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_ReflectedTowerDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_ReflectDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_RecoilDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_RangedDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_PushbackDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_PulseDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_PowerShotDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_PoisonDamagePerSecond",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_MeleeDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_LandingDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_JumpDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_IceBlastDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_ExtraChainDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_DeathDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_DashDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_DamagePerSecond",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_DamagePerBlast",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_Damage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_CrownTowerDamagePerSecond",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_CrownTowerDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_ComboDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_CloseQuartersDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_ChargeDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_BuildingDamagePerSecond",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_BounceDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_BonusDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_BarrageDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Stats_Damage_AreaDamage",
                table: "Troops",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_AlliesBuff",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_AlliesSpeedBoost",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_BackwardTeleport",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Barrage",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_BuildingSummon",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Charge",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Clone",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Curse",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_DamageBoost",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_DamageReduction",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Dash",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_DualForm",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_ElixirCollect",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_EnemiesSpeedReduction",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Freeze",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Grab",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Heal",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Invincibility",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Invisible",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Jump",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_KeepMaxDamage",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Knockback",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Mirror",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_MultipleTroops",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_MultiplesDash",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_PullToCenter",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Redeploy",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_ReflectProjectiles",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Resurrect",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SecondaryAttack",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Shield",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SideSwitchTeleport",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Slow",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Snare",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SoulsCollect",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SpellSummon",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Stun",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SwitchToAir",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SwitchToBuilding",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_SwitchToGround",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_Taunt",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Mechanic_TroopSummon",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Movement_Air",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Movement_Ground",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Speed_Fast",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Speed_Medium",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Speed_Slow",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Speed_VeryFast",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Target_Air",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Target_Both",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Target_Buildings",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Target_Ground",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_Activation",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnAttack",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnChargeComplete",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnClick",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnDamageTaken",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnDeath",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnDeploy",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnDurationEnd",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnHit",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_OnTargetReached",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Trigger_Passive",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TroopType_Building",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TroopType_Spell",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TroopType_Troop",
                table: "Troops",
                type: "REAL",
                nullable: true);
        }
    }
}
