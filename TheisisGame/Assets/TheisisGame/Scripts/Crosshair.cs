//This script communicates with the player movement script
/*[SerializeField]
[Header("Only on speed boost")] float _speedBoost;
[SerializeField]
[Header("Only on jump pad")] float _springStrength;

void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {
        if (gameObject.tag == "JumpPad")
        {
            _pm.MoveDirection = new Vector3(0, _springStrength, 0); //Makes the player jump higher
        }

    }
}
void OnTriggerExit(Collider other) //Resetting the players speed
{
    if (other.tag == "Player" && gameObject.tag == "SpeedBoost")
    {
        _pm.AbleToSprint = true;
        _pm.Speed = _pm.NormalSpeed;
        _pm.Boosted = false;
    }
}*/